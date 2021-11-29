//
//  singleNewsRss.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 18.08.2021.
//

import Foundation

struct NewsItem : Identifiable, Hashable {
    let id: Int
    
    var title: String = ""
    var description: String = ""
    var pubdate: String = ""
    var link: String = ""
    var image: URL?
    
    func hash(into hasher: inout Hasher) {
        hasher.combine(id)
        hasher.combine(link)
        hasher.combine(pubdate)
    }
}
