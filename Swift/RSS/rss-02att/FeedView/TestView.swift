//
//  TestView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 01.09.2021.
//

import SwiftUI
import UserNotifications



struct TestView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    var notificationCenter = UNUserNotificationCenter.current()
    var body: some View {
        VStack {
            Text("TestView".localized(language))
                .font(.title)
            Button("RequestPermission".localized(language)) {
                debugPrint("permission req")
                notificationCenter.requestAuthorization(options: [.alert,.badge,.sound]) { success, error in
                    if success {
                        debugPrint("Notification successfully permitted")
                    } else if let error = error {
                        debugPrint(error.localizedDescription)
                    }
                }
            }
            Button("SendNotification".localized(language)) {
                let content = UNMutableNotificationContent()
                content.title = "NotificationTitle".localized(language)
                content.subtitle = "NotificationSubtitle".localized(language)
                content.sound = UNNotificationSound.default
                let triggerNotification = UNTimeIntervalNotificationTrigger(timeInterval: 5, repeats: false)
                let requestNotification = UNNotificationRequest(identifier: UUID().uuidString, content: content, trigger: triggerNotification)
                notificationCenter.add(requestNotification)
            }
            
            Button("CheckAllData".localized(language)) {
                DBManager().showAllImagesData()
            }
            Button("DeleteAllData".localized(language)) {
                DBManager().deleteEveryImage()
            }
        }
    }
}

struct TestView_Previews: PreviewProvider {
    static var previews: some View {
        TestView()
    }
}
