//
//  LoginView.swift
//  rss-02att
//
//  Created by Mykhailo Zorin on 10.09.2021.
//

import SwiftUI

struct AlertCustom {
    let title: String
    let message: String
}

struct PasswordView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @Binding var isSecured: Bool
    @Binding var password: String
    var body: some View {
        ZStack(alignment: .trailing) {
            if isSecured {
                SecureField("Password".localized(language), text: $password)
                    .textFieldStyle(RoundedBorderTextFieldStyle())
                    .font(.title)
            } else {
                TextField("Password".localized(language), text: $password)
                    .textFieldStyle(RoundedBorderTextFieldStyle())
                    .font(.title)
            }
            Button(action: {
                isSecured.toggle()
            }, label: {
                Image(systemName: self.isSecured ? "eye.slash" : "eye")
            })
        }
    }
}

struct LoginView: View {
    @AppStorage("language")
    private var language = LocalizationService.shared.language
    
    @Binding var willMoveToTheNextScreen: Bool
    
    @State var username: String = ""
    @State var password: String = ""
    @State var passwordConfirmed: String = ""
    @State var isSecuredFirst: Bool = true
    @State var isSecuredSecond: Bool = true
    @State var isError: Bool = false
    @State var signIn: Bool = false
    
    @State var alert = AlertCustom(title: "", message: "")
    
    var body: some View {
        NavigationView {
            VStack(spacing: 40) {
                TextField("Username".localized(language), text: $username)
                    .textFieldStyle(RoundedBorderTextFieldStyle())
                    .font(.title)
                PasswordView(isSecured: $isSecuredFirst, password: $password)
                if signIn {
                    PasswordView(isSecured: $isSecuredSecond, password: $passwordConfirmed)
                }
                HStack {
                    if !signIn {
                        Spacer()
                        Button(action: {
                            do {
                                try self.login()
                            } catch LoginError.incompleteForm{
                                debugPrint("Incomplete form")
                                alert = AlertCustom(title: "Incomplete form", message: "Please fill both fields")
                                self.isError = true
                            } catch LoginError.incorrectPasswordLength {
                                debugPrint("Incorrect password length")
                                alert = AlertCustom(title: "Password too short", message: "Password should be at least 8 characters")
                                self.isError = true
                            } catch LoginError.invalidUsername {
                                debugPrint("Invalid username")
                                alert = AlertCustom(title: "Invalid username format", message: "Use letters of the same register")
                                self.isError = true
                            } catch {
                                debugPrint(error.localizedDescription)
                            }
                        }) {
                            Text("Login".localized(language))
                                .font(.title)
                        }
                        .alert(isPresented: $isError) {
                            Alert(title: Text(alert.title.localized(language)),
                                  message: Text(alert.message.localized(language)),
                                  dismissButton: .default(Text("Ok")))
                        }
                        Spacer()
                        Button(action: {
                            signIn = true
                        }) {
                            Text("Sign in".localized(language))
                                .font(.title)
                        }
                        Spacer()
                    } else {
                        Button (action: {
                            do {
                                try registration()
                            } catch {
                                debugPrint(error.localizedDescription)
                            }
                        }) {
                            Text("Register".localized(language))
                                .font(.title)
                        }
                    }
                }
                
            }
            .padding()
            .navigationBarTitle("Fast News App")
            .toolbar {
                ToolbarItem {
                    Menu {
                        Button {
                            LocalizationService.shared.language = .english
                        } label: {
                            Text("English")
                            flagBy(countryCode: "US")
                            
                        }
                        Button {
                            LocalizationService.shared.language = .russian
                        } label: {
                            Text("Русский")
                            flagBy(countryCode: "RU")
                        }
                    } label: {
                        flagBy(countryCode: language.rawValue.uppercased())
                            .resizable()
                            .frame(width: 50, height: 50)
                    }
                }
            }
        }
    }
    
    enum LoginError: Error {
        case incompleteForm
        case invalidUsername
        case incorrectPasswordLength
        case mismatchedPasswords
    }
    
    func login() throws {
        let name = username
        let pass = password
        
        
        if name.isEmpty || pass.isEmpty {
            throw LoginError.incompleteForm
        }
        if pass.count < 8 {
            throw LoginError.incorrectPasswordLength
        }
        if name.uppercased() != name.lowercased() {
            throw LoginError.invalidUsername
        }
        
        if name == "1111" && pass.count == 8 { // check existance of user
            self.willMoveToTheNextScreen = true
        }
    }
    
    func registration() throws {
        let name = username
        let pass = password
        let pass2 = passwordConfirmed
        if name.isEmpty || pass.isEmpty || pass2.isEmpty {
            throw LoginError.incompleteForm
        }
        if pass.count < 8 && pass2.count < 8 {
            throw LoginError.incorrectPasswordLength
        }
        if name.uppercased() != name.lowercased() {
            throw LoginError.invalidUsername
        }
        if pass != pass2 {
            throw LoginError.mismatchedPasswords
        }
        if name == "1111" && pass.count == 8 { // check existance of use
            // adding user to db
            self.willMoveToTheNextScreen = true
        }
    }
}

struct LoginView_Previews: PreviewProvider {
    static var previews: some View {
        LoginView(willMoveToTheNextScreen: .constant(false))
    }
}
