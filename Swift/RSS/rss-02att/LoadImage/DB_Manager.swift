//
//  DB_Manager.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 31.08.2021.
//

import Foundation
import SQLite

class DBManager {
    private var db: Connection!
    private var images: Table!
    
    private var url: Expression<String>!
    private var imageData: Expression<String>!
    
    init(){
        do {
            let path: String = NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true).first ?? ""
            db = try Connection("\(path)/imagesTable.sqlite3")
            
            images = Table("images")
            
            url = Expression<String>("url")
            imageData = Expression<String>("imageData")
            
            if (!UserDefaults.standard.bool(forKey: "is_db_created")) {
                try db.run(images.create { (table) in
                    table.column(url, primaryKey: true)
                    table.column(imageData)
                })
                UserDefaults.standard.set(true, forKey: "is_db_created")
            }
        } catch {
            debugPrint(error.localizedDescription)
        }
    }

    public func addNewImage(urlValue: String, imageValue: String){
        do {
            try db.run(images.insert(url <- urlValue, imageData <- imageValue))
        } catch {
            //debugPrint(error.localizedDescription)
        }
    }
    
    public func showAllImagesData() {
        images = images.order(url)
        do {
            debugPrint("Data starts here")
            for image in try db.prepare(images){
                debugPrint(image[url])
                debugPrint(image[imageData].count)
            }
            debugPrint("Data ends here")
            return
        } catch {
            debugPrint(error.localizedDescription)
        }
    }
        
    private func deleteImage(_ urlValue: String) {
        do {
            let image: Table = images.filter(url == urlValue)
            try db.run(image.delete())
        } catch {
            debugPrint(error.localizedDescription)
        }
    }
    
    public func deleteEveryImage() {
        images = images.order()
        do {
            for image in try db.prepare(images) {
                let imageURL = image[url]
                deleteImage(imageURL)
            }
            debugPrint("All data successfully deleted")
        } catch {
            debugPrint(error.localizedDescription)
        }
    }
}
