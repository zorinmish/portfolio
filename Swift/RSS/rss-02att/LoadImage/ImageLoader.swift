//
//  ImageLoader.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 26.08.2021.
//

import Combine
import UIKit
import SwiftUI

class ImageLoader : ObservableObject {
    @Published var image: UIImage? {
        didSet {
            let imageData: String = image?.jpegData(compressionQuality: 1)?.base64EncodedString() ?? ""
            DBManager().addNewImage(urlValue: url.absoluteString, imageValue: imageData)
        }
    }
    
    private let url: URL
    private var cancellable: AnyCancellable?
    private var cache: ImageCache?
    private(set) var isLoading = false
    
    private static let imageProcessingQueue = DispatchQueue(label: "image-processing")
    
    init(url: URL, cache: ImageCache? = nil) {
        self.url = url
        self.cache = cache
    }
    deinit {
        cancel()
    }
    
    func load() {
        guard !isLoading else {return}
        
        if let image = cache?[url] {
            self.image = compressImage(image)
            return
        }
        
        cancellable = URLSession.shared.dataTaskPublisher(for: url)
            .subscribe(on: Self.imageProcessingQueue)
            .map { UIImage(data: $0.data)?.resized(withPercentage: 0.4) }
            .replaceError(with: nil)
            .handleEvents(receiveSubscription: { [weak self] _ in self?.onStart() },
                          receiveOutput: { [weak self] in
                            self?.cache($0) },
                          receiveCompletion: { [weak self] _ in
                            //sleep(1)
                            self?.onFinish() },
                          receiveCancel: { [weak self] in self?.onFinish() } )
            .receive(on: DispatchQueue.main)
            .sink { [weak self] in
                if let image = $0 {
                    self?.image = self?.uncompressImage(image)
                }
            }
    }
    
    private func onStart() {
        isLoading = true
    }
    
    private func onFinish() {
        isLoading = false
    }
    
    private func cache(_ image: UIImage?) {
        image.map { cache?[url] = $0 }
    }
    
    func cancel() {
        cancellable?.cancel()
    }
    
    private func compressImage(_ image: UIImage?) -> UIImage? {
        guard let image = image else { return nil }
        
        let resizer = Resizer(image, xScale: 0.3, yScale: 0.3)
        
        let colorFilter = ColorFilter(resizer)
        colorFilter.update(contrast: 0.9)
        colorFilter.update(brightness: 0.1)
        
        return colorFilter.apply()
    }
    
    private func uncompressImage(_ image: UIImage?) -> UIImage? {
        guard let image = image else { return nil }
        
        let resizer = Resizer(image, xScale: 0.6, yScale: 0.6)
        
        let colorFilter = ColorFilter(resizer)
        colorFilter.update(contrast: 1)
        
        return colorFilter.apply()
    }
}
