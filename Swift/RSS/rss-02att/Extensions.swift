//
//  ExtensionsForString.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 18.08.2021.
//

import Foundation
import SwiftUI
import FlagKit

func flagBy(countryCode: String) -> Image {
    guard let flag = Flag(countryCode: countryCode) else {
        return Image(systemName: "questionmark.circle")
    }
    return Image(uiImage: flag.image(style: .circle))
}

func extractURLbySeparator(text : String, sep: String) -> URL? {
    let arr = text.indices(of: sep)
    if arr.count < 2 { return nil }
    let range = text.index(arr[0], offsetBy: 1)..<arr[1]
    let stringURL = String(text[range])
    return URL(string: stringURL)
}

func extractTime(text : String) -> String {
    let arr = text.indices(of: ":")
    if arr.count < 2 { return text }
    let range = text.startIndex..<arr[1]
    return String(text[range])
}

extension Date {
    static func - (lhs: Date, rhs: Date) -> TimeInterval {
        return lhs.timeIntervalSinceReferenceDate - rhs.timeIntervalSinceReferenceDate
    }
}

extension StringProtocol {
    func index<S: StringProtocol>(of string: S, options: String.CompareOptions = []) -> Index? {
        range(of: string, options: options)?.lowerBound
    }
    func endIndex<S: StringProtocol>(of string: S, options: String.CompareOptions = []) -> Index? {
        range(of: string, options: options)?.upperBound
    }
    func indices<S: StringProtocol>(of string: S, options: String.CompareOptions = []) -> [Index] {
        ranges(of: string, options: options).map(\.lowerBound)
    }
    func ranges<S: StringProtocol>(of string: S, options: String.CompareOptions = []) -> [Range<Index>] {
        var result: [Range<Index>] = []
        var startIndex = self.startIndex
        while startIndex < endIndex,
            let range = self[startIndex...]
                .range(of: string, options: options) {
                result.append(range)
                startIndex = range.lowerBound < range.upperBound ? range.upperBound :
                    index(range.lowerBound, offsetBy: 1, limitedBy: endIndex) ?? endIndex
        }
        return result
    }
}

extension UIImage {
    func resized(withPercentage percentage: CGFloat, isOpaque: Bool = true) -> UIImage? {
        let canvas = CGSize(width: size.width * percentage, height: size.height * percentage)
        let format = imageRendererFormat
        format.opaque = isOpaque
        return UIGraphicsImageRenderer(size: canvas, format: format).image {
            _ in draw(in: CGRect(origin: .zero, size: canvas))
        }
    }
}

/*
extension String {
    func load() -> UIImage {
        do {
            guard let url = URL(string: self) else {
                return UIImage()
            }
            let data: Data = try Data(contentsOf: url)
            return UIImage(data: data) ?? UIImage()
        } catch {
        }
        return UIImage()
    }
}
 */


