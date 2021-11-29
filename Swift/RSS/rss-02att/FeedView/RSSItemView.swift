//
//  singleNewsView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 19.08.2021.
//

import SwiftUI

struct RSSItemView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @Binding var isLoaded: Bool
    let news: NewsItem
    let isExpanded: Bool
    var body: some View {
        HStack{
            content
            Spacer()
        }
        .frame(minWidth: 120, maxWidth: .infinity, minHeight: 150, maxHeight: isExpanded ? 270 : 150, alignment: .center)
        .contentShape(Rectangle())
    }
    
    private var content : some View {
        HStack{
            ZStack {
                //Image(uiImage: news.image.load())
                if let image = news.image {
                    AsyncImage(isLoaded: $isLoaded, url: image, placeholder: { Text("Loading".localized(language)) })
                        .frame(width: 120.0, height: 120.0)
                        .padding()
                } else {
                    Image(systemName: "questionmark")
                        .resizable()
                        .aspectRatio(contentMode: .fit)
                }
            }
            .cornerRadius(0)
            .frame(width: 120, height: 120)
            Group{
                if isExpanded {
                    VStack(alignment: .leading, spacing: 25)  {
                        ScrollView {
                            Text(news.title)
                                .font(.headline)
                            Spacer(minLength: 15)
                            Text(news.description)
                        }
                        Text(extractTime(text: news.pubdate))
                    }
                } else {
                    VStack(alignment: .leading) {
                        Text(news.title)
                            .lineLimit(3)
                            .font(.headline)
                        Text(news.description)
                            .lineLimit(2)
                            .font(.subheadline)
                            .foregroundColor(Color.gray)
                    }
                }
            }
            .padding()
        }
    }
}

/*
struct singleNewsView_Previews: PreviewProvider {
    static var previews: some View {
        RSSItemView(isLoaded: <#Binding<Bool>#>, news: NewsItem(id: 0, title: "Krystsina Tsimanouskaya wants to have a citizenship application fast-tracked to allow her to run for Poland after defecting from Belarus during the Olympics.", description: "Peel’s dual premiership coach Cam Shepherd is eager to seek another football job after coming to an amicable agreement with Fremantle to leave the Thunder at the end of the season.", pubdate: "Thu, 19 Aug 2021 12:13:00 -0400", link: "lll", image: nil),isExpanded: true)
    }
}
 */

// URL(string: "https://images.thewest.com.au/publication/C-3728340/291f7a96780a9eb8f386825d8e46e22d85500051-16x9-x0y0w1280h720.jpg")
