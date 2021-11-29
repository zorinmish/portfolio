//
//  SettingView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 06.08.2021.
//

import Foundation
import SwiftUI
import FlagKit

struct SettingsView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @Binding var feedsSaved: [FeedInfo]
    @State private var localFeeds: [FeedInfo]
    @State private var successSavedAlert = false
        
    init(feeds: Binding<[FeedInfo]>){
        self._feedsSaved = feeds
        self._localFeeds = State(initialValue: feeds.wrappedValue)
    }
    
    var body: some View {
        List(0..<3) { item in
            VStack {
                Spacer(minLength: 20)
                TextField("FeedName".localized(language), text: $localFeeds[item].feedName)
                    .textFieldStyle(RoundedBorderTextFieldStyle())
                    .font(.title)
                TextField("FeedURL".localized(language), text: $localFeeds[item].feedURL)
                    .textFieldStyle(RoundedBorderTextFieldStyle())
                    .font(.title2)
                Slider(value: $localFeeds[item].feedRefreshRate, in: 10...100)
                Text("Refresh %lld feed every %@ sec".localized(language, args: item+1, String(format: "%.0f",localFeeds[item].feedRefreshRate)))
                    .font(.subheadline)
            }
        }
        .padding()
        .navigationTitle("SettingsTitle".localized(language))
        .toolbar {
            ToolbarItem(placement: .navigationBarTrailing){
                Button("SaveButton".localized(language)) {
                    if feedsSaved != localFeeds {
                        successSavedAlert = true
                        feedsSaved = localFeeds
                    }
                }
            }
        }
        .alert(isPresented: $successSavedAlert) {
            Alert(title: Text("Success".localized(language)), message: Text("AllChangeSaved".localized(language)), dismissButton: .default(Text("Ok")))
        }
    }
}
