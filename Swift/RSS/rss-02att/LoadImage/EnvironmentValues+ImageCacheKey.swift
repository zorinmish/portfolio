//
//  EnvironmentValues+ImageCacheKey.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 27.08.2021.
//

import SwiftUI

struct ImageCacheKey: EnvironmentKey {
    static let defaultValue: ImageCache = TemporaryImageCache()
}

extension EnvironmentValues {
    var imageCache: ImageCache {
        get { self[ImageCacheKey.self]}
        set { self[ImageCacheKey.self] = newValue}
    }
}
