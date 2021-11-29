//
//  AsyncImageView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 26.08.2021.
//

import SwiftUI

struct AsyncImage<Placeholder: View>: View {
    @Binding var isLoaded: Bool
    @StateObject private var loader: ImageLoader
    private let placeholder : Placeholder
    
    
    init(isLoaded: Binding<Bool>,url: URL, @ViewBuilder placeholder: () -> Placeholder) {
        self._isLoaded = isLoaded
        self.placeholder = placeholder()
        _loader = StateObject(wrappedValue: ImageLoader(url: url, cache: Environment(\.imageCache).wrappedValue))
    }
    
    var body: some View {
        
        content
            .onAppear(perform: loader.load)
        
    }
    
    private var content: some View {
        Group {
            if loader.image != nil && isLoaded == true {
                Image(uiImage: loader.image!)
                    .resizable()
                    .aspectRatio(contentMode: .fill)
            }
            else {
                placeholder
            }
        }
    }
}
