//
//  AllTabsView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 10.09.2021.
//

import SwiftUI

struct AllTabsView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @State var feeds: [FeedInfo] = testData
    @State var selection = 4
    
    var body: some View {
        TabView(selection: $selection) {
            //1
            NavigationView {
                FeedListView(feedInfo: $feeds[0], selectedTab: $selection)
            }.tabItem {
                Image(systemName: "star")
                Text(feeds[0].feedName)
            }
            .tag(1)
            
            //2
            NavigationView{
                FeedListView(feedInfo: $feeds[1], selectedTab: $selection)
            }.tabItem {
                Image(systemName: "star.fill")
                Text(feeds[1].feedName)
            }
            .tag(2)
            
            //3
            NavigationView() {
                FeedListView(feedInfo: $feeds[2], selectedTab: $selection)
            }.tabItem {
                Image(systemName: "heart.fill")
                Text(feeds[2].feedName)
            }
            .tag(3)
            
            //Settings
            NavigationView() {
                SettingsView(feeds: $feeds)
            }
            .tabItem {
                Image(systemName: "person.fill")
                Text(("SettingsTitle".localized(language)))
            }
            .tag(4)
            
            
            NavigationView() {
                TestView()
            }
            .tabItem {
                Image(systemName: "person")
            }
            .tag(5)
        }
    }
}

struct AllTabsView_Previews: PreviewProvider {
    static var previews: some View {
        AllTabsView()
    }
}


let testData = [FeedInfo(feedNumber: 1, feedName: "NPR", feedURL: "https://www.npr.org/rss/rss.php?id=1001", feedRefreshRate: 60.0, feedType: .first), FeedInfo(feedNumber: 2, feedName: "TheWest", feedURL: "https://thewest.com.au/sport/rss", feedRefreshRate: 60.0, feedType: .second), FeedInfo(feedNumber: 3, feedName: "CBN", feedURL: "http://www1.cbn.com/app_feeds/rss/news/rss.php?section=world", feedRefreshRate: 60.0, feedType: .third)]
