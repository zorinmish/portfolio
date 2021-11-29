//
//  LoadDataFunc.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 19.08.2021.
//

import Foundation

func loadData(urlString: String, type: FeedType, completion: @escaping (DataParser?, Error?)->Void)
{
    let firstTypeFeedResult = firstTypeParseRSS()
    let secondTypeFeedResult = secondTypeParseRSS()
    let thirdTypeFeedResult = thirdTypeParseRSS()

    if let url = URL(string: urlString) {
        let request = URLRequest(url: url)
        let session = URLSession.shared.dataTask(with: request) {
            (data, _, error) in
            if error != nil { return }
            guard let data = data else { return }
            
            var dataString: String = String(data: data, encoding: .ascii)!
            dataString = dataString.replacingOccurrences(of: "\r", with: "\n")
            
            switch type {
            case .first:
                firstTypeFeedResult.setData(data: data)
                firstTypeFeedResult.parse()
                completion(firstTypeFeedResult, nil)
            case .second:
                secondTypeFeedResult.setData(data: data)
                secondTypeFeedResult.parse()
                completion(secondTypeFeedResult, nil)
            case .third:
                thirdTypeFeedResult.setData(data: data)
                thirdTypeFeedResult.parse()
                completion(thirdTypeFeedResult, nil)
            }
        }
        session.resume()
    }
    else {
        completion(nil, nil)
    }
}
