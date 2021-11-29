import Foundation

enum FeedType {
    case first
    case second
    case third
}

struct FeedInfo : Equatable{
    var feedNumber: Int
    var feedName: String
    var feedURL: String
    var feedRefreshRate: Double
    var feedType: FeedType
    
    static func == (lhs: FeedInfo, rhs: FeedInfo) -> Bool {
        return lhs.feedName == rhs.feedName && lhs.feedURL == rhs.feedURL && lhs.feedRefreshRate == rhs.feedRefreshRate
    }
}
