//
//  FirstFeedView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 16.08.2021.
//

import SwiftUI



struct FeedListView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @Binding var feedInfo : FeedInfo
    @Binding var selectedTab: Int
    
    init (feedInfo: Binding<FeedInfo>, selectedTab: Binding<Int>) {
        self._feedInfo = feedInfo
        self._selectedTab = selectedTab
        self.timerUpdateView = Timer.publish(every: feedInfo.feedRefreshRate.wrappedValue, tolerance: 0.2, on: .main, in: .common).autoconnect()
    }
    
    @State var dataRSS : [NewsItem] = []
    @State var loadedRSS: [NewsItem] = []
    @State var isLoading : Bool = false
    @State var lastRefreshTime: Date = Date()
    @State var numberOfUpdatedImages: Int = 0
    
    @State private var selection: Set<NewsItem> = []
    @State var updatedImages : [Bool] = Array (repeating: false, count: 10 )
    
    let timerUpdateImage = Timer.publish(every: 1, tolerance: 0.1, on: .main, in: .common).autoconnect()
    var timerUpdateView = Timer.publish(every: .infinity, tolerance: 0.2, on: .main, in: .common).autoconnect()
    
    var itemsOnTab : Int {
        if dataRSS.isEmpty { return 0 }
        else { return min(dataRSS.count, 10) }
    }
    @State var isDataParsed: Bool = false {
        didSet {
            dataRSS = loadedRSS
            loadedRSS = []
        }
    }
    
    func selectDeselect(_ singleNews: NewsItem) {
        var foundSelection = false
        for cell in selection {
            if !foundSelection {
                if cell == singleNews {
                    selection.remove(singleNews)
                    foundSelection = true
                }
             }
        }
        if !foundSelection {
            selection.insert(singleNews)
            return
        }
    }
    
    func updateData() {
        isDataParsed = false
        isLoading = true
        selection = []
        updatedImages = Array(repeating: false, count: 10)
        numberOfUpdatedImages = 0
        
        loadData(urlString: feedInfo.feedURL, type: feedInfo.feedType) {
            (rss, error) in
            rss?.items.forEach { item in
                loadedRSS.append(item)
            }
            isLoading = false
            isDataParsed = true
            lastRefreshTime = Date()
        }
    }
    
    var body: some View {
        if isDataParsed {
            Group {
                if dataRSS.count > 0 {
                    ScrollView() {
                        ForEach(0..<itemsOnTab) { i in
                            RSSItemView(isLoaded: $updatedImages[i], news: dataRSS[i], isExpanded: self.selection.contains(dataRSS[i]))
                                .onTapGesture { self.selectDeselect(dataRSS[i]) }
                                .modifier(ListRowModifier())
                                .animation(.linear(duration: 0.3))

                        }
                    }
                    .onReceive(timerUpdateImage, perform: { _ in
                        if numberOfUpdatedImages < itemsOnTab {
                            updatedImages[numberOfUpdatedImages] = true
                            numberOfUpdatedImages+=1
                        } else {
                            self.timerUpdateImage.upstream.connect().cancel()
                        }
                    })
                } else {
                    VStack(alignment: .center, spacing: 30) {
                        Text("NoNewsURLTitle".localized(language))
                            .font(.largeTitle)
                        Text("NoNewsURLSubtitle".localized(language))
                            .font(.title)
                            .foregroundColor(.gray)
                    }
                }
            }
            .onAppear() {
                if Date() - lastRefreshTime > feedInfo.feedRefreshRate { // refresh rate in seconds
                    updateData()
                    lastRefreshTime = Date()
                }
            }
            .onReceive(timerUpdateView, perform: { _ in
                debugPrint("View \(feedInfo.feedName) want to update")
                if selectedTab == feedInfo.feedNumber {
                    debugPrint("View recieved this opportunity")
                    updateData()
                    lastRefreshTime = Date()
                } else {
                    debugPrint("But it can not")
                }
                
            })
            .navigationTitle(feedInfo.feedName)
            .toolbar {
                ToolbarItem(placement: .navigationBarTrailing) {
                    Button(action: {
                        updateData()
                    }, label: {
                        Image(systemName: "arrow.clockwise")
                    })
                }
            }
        } else {
            VStack(alignment: .center) {
                if isLoading {
                    ProgressView()
                        .progressViewStyle(CircularProgressViewStyle(tint: .gray))
                        .scaleEffect(3)
                        .navigationTitle(feedInfo.feedName)
                        .toolbar {
                            ToolbarItem(placement: .navigationBarTrailing) {
                                Button(action: {
                                    updateData()
                                }, label: {
                                    Image(systemName: "arrow.clockwise")
                                })
                            }
                        }
                } else {
                    Spacer()
                        .onAppear {
                            updateData()
                        }
                }
            }
        }
    }
}

struct ListRowModifier: ViewModifier {
    func body(content: Content) -> some View {
        Group {
            content
            Divider()
        }.offset(x: 20)
    }
}
