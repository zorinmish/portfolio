import Foundation

class DataParser : NSObject, XMLParserDelegate
{
    fileprivate var myData: Data
    fileprivate var currentElementName = ""
    fileprivate var inItem = false
    fileprivate var item: NewsItem
    fileprivate var dict: [String: String] = [:]
    var ready = false
    var items: [NewsItem]
    var header: NewsItem
    
    override init(){
        myData = "".data(using: .ascii)!
        header = NewsItem(id: -1)
        items = []
        item = header
    }
    
    func setData(data: Data!) -> Void {
        if data == nil { return }
        myData  = data
    }
    
    // run parsing of the XML data
    func parse() -> Void
    {
        let parser = XMLParser(data:myData)
        parser.delegate = self
        parser.parse()
    }
    
    func parserDidEndDocument(_ parser: XMLParser) { ready = true }
    
    func parserDidStartDocument(_ parser: XMLParser) { ready = false }
    
    // Item is fully specified
    func parser(_ parser: XMLParser, didEndElement elementName: String, namespaceURI: String?, qualifiedName qName: String?) {
        currentElementName = elementName
        if elementName == "item" {
            inItem = false
            items.append(item)
        }
    }
    
    // New item or media content found
    func parser(_ parser: XMLParser, didStartElement elementName: String, namespaceURI: String?, qualifiedName qName: String?, attributes attributeDict: [String : String] = [:]) {
        currentElementName = elementName
        if elementName == "media:content" {
            dict = attributeDict
        }
        if elementName == "item"{
            inItem = true
            item = NewsItem(id: items.count)
        }
    }
    
    // Parse XML simple strings (func to override)
    func parser(_ parser: XMLParser, foundCharacters string: String) {}
    
    // Collect data from CDATA blocks (func to override)
    func parser(_ parser: XMLParser, foundCDATA CDATABlock: Data) {}
}


class firstTypeParseRSS {
    var dataParser: DataParser = DataParser()
    func parser(_ parser: XMLParser, foundCDATA CDATABlock: Data) {
        if !dataParser.inItem { return }
        
        switch dataParser.currentElementName.lowercased() {
        case "content:encoded":
            dataParser.item.image = extractURLbySeparator(text: String(data: CDATABlock, encoding: .utf8) ?? "", sep: "\'")
        default:
            break
        }
    }
    
    func parser(_ parser: XMLParser, foundCharacters string: String) {
        if !dataParser.inItem { return }
        
        let trimmedString = string.trimmingCharacters(in: CharacterSet.whitespacesAndNewlines)
        switch dataParser.currentElementName.lowercased() {
        case "title":
            dataParser.item.title += trimmedString
        case "description":
            dataParser.item.description += trimmedString
        case "pubdate":
            dataParser.item.pubdate += trimmedString
        case "link":
            dataParser.item.link += trimmedString
        default:
            break
        }
    }
}

class secondTypeParseRSS : DataParser {
    override func parser(_ parser: XMLParser, foundCharacters string: String) {
        if !inItem { return }
        
        let trimmedString = string.trimmingCharacters(in: CharacterSet.whitespacesAndNewlines)
        switch currentElementName.lowercased() {
        case "pubdate":
            item.pubdate += trimmedString
        case "link":
            item.link += trimmedString
        case "media:content":
            item.image = URL(string: dict["url"] ?? "")
        default:
            break
        }
    }
    
    override func parser(_ parser: XMLParser, foundCDATA CDATABlock: Data) {
        if !inItem { return }
        
        let CDATAString = String(data: CDATABlock, encoding: .utf8) ?? ""
        switch currentElementName.lowercased() {
        case "title":
            item.title = CDATAString
        case "description":
            item.description = CDATAString
        default:
            break
        }
    }
}

class thirdTypeParseRSS: DataParser {
    override func parser(_ parser: XMLParser, foundCharacters string: String) {
        if !inItem { return }
        
        let trimmedString = string.trimmingCharacters(in: CharacterSet.whitespacesAndNewlines)
        switch currentElementName.lowercased() {
        case "link":
            item.link += trimmedString
        case "pubdate":
            item.pubdate += trimmedString
        default:
            break
        }
    }
    
    override func parser(_ parser: XMLParser, foundCDATA CDATABlock: Data) {
        if !inItem { return }
        
        let CDATAString = String(data: CDATABlock, encoding: .utf8) ?? ""
        switch currentElementName.lowercased() {
        case "title":
            item.title = CDATAString
        case "description":
            item.description = CDATAString
        case "thumbnail":
            item.image = URL(string: CDATAString)
        default:
            break
        }
    }
}
