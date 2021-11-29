//
//  ContentView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 04.08.2021.
//

import SwiftUI


struct ContentView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @State var feeds: [FeedInfo] = testData
    @State var selection = 4
    @State var loginDone = true
    
    var body: some View {
        if !loginDone {
            LoginView(willMoveToTheNextScreen: $loginDone)
        } else {
            AllTabsView()
        }
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
