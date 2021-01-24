#include <iostream>
#include <vector>
#include <map>
#include <set>
#include <sstream>
#include <string>
#include <fstream>
#include <exception>

using namespace std;

void clear()
{
    cout << "\x1B[2J\x1B[H";
}

class Magazine
{
public:
    static int count;
    Magazine(){};
    Magazine(string name, string category, string publish, int num)
    {
        count++;
        ID_mag = count;
        Name_mag = name;
        Category = category;
        Publishing = publish;
        Num_of_pages = num;
    }

    int ID_mag;
    string Name_mag;
    string Category;
    string Publishing;
    int Num_of_pages;
};
int Magazine::count = 0;

class Crosswords : public Magazine
{
public:
    Crosswords(string name, string category, string publish, int num, int dif)
    {
        count++;
        ID_mag = count;
        Name_mag = name;
        Category = category;
        Publishing = publish;
        Num_of_pages = num;
    }
    int difficulty;
};

class TV_programs : public Magazine
{
public:
    TV_programs(string name, string category, string publish, int num, string str)
    {
        count++;
        ID_mag = count;
        Name_mag = name;
        Category = category;
        Publishing = publish;
        Num_of_pages = num;
        type_of_TV_programs = str;
    }
    string type_of_TV_programs;
};

class Calendar : public Magazine
{
public:
    Calendar(string name, string category, string publish, int num, int y)
    {
        count++;
        ID_mag = count;
        Name_mag = name;
        Category = category;
        Publishing = publish;
        Num_of_pages = num;
        year = y;
    }
    int year;
};

class Catalog
{
public:
    static int count;
    Catalog(){};
    Catalog(Magazine &mag, double price, int avail)
    {
        count++;
        ID = count;
        magazine = mag;
        Price = price;
        Availability = avail;
        Sypher = "ID_" + to_string(magazine.ID_mag) + "_" + to_string(magazine.Num_of_pages);
    }

    int ID;
    Magazine magazine;
    string Sypher;
    double Price;
    int Availability;
    int Catalog::count = 0;
};

class Shop
{
public:
    void Show_magazines()
    {
        cout << "Now in shop - " << Magazines.size() << " magazines" << endl;
        cout << "------------------------------------" << endl;
        for (const auto &magazine : Magazines)
        {
            cout << "ID : " << magazine.ID_mag << endl;
            cout << "Name : " << magazine.Name_mag << endl;
            cout << "Category : " << magazine.Category << endl;
            cout << "Publishing : " << magazine.Publishing << endl;
            cout << "Number of pages : " << magazine.Num_of_pages << "p." << endl;
            cout << "------------------------------------" << endl;
        }
    }
    void Add_magazine()
    {
        string name, categ, publish;
        int num;
        cout << "Adding new magazine" << endl;
        cout << "Name of magazine: ";
        cin >> name;
        cout << "Category of the magazine: ";
        cin >> categ;
        cout << "Publishing of the magazine: ";
        cin >> publish;
        cout << "Number of pages: ";
        cin >> num;
        if (categ == "Crosswords")
        {
            int dif;
            cout << "Enter difficulty" << endl;
            cin >> dif;
            Crosswords new_magazine(name, categ, publish, num, dif);
            Magazines.push_back(new_magazine);
        }
        else
        {
            if (categ == "TV-programs")
            {
                string str;
                cout << "Enter type of TV-program" << endl;
                cin >> str;
                TV_programs new_magazine(name, categ, publish, num, str);
                Magazines.push_back(new_magazine);
            }
            else
            {
                if (categ == "Calendar")
                {
                    int y;
                    cout << "Year: " << endl;
                    cin >> y;
                    Calendar new_magazine(name, categ, publish, num, y);
                    Magazines.push_back(new_magazine);
                }
                else
                {
                    Magazine new_magazine(name, categ, publish, num);
                    Magazines.push_back(new_magazine);
                }
            }
        }
    }

    void Show_in_shop()
    {
        cout << "Now in shop's catalog " << In_shop.size() << " different magazines" << endl;
        for (const auto &catalog : In_shop)
        {
            cout << "Sypher : " << catalog.Sypher << endl;
            cout << "Name : " << catalog.magazine.Name_mag << endl;
            cout << "Category : " << catalog.magazine.Category << endl;
            cout << "Publishing : " << catalog.magazine.Publishing << endl;
            cout << "Price : " << catalog.Price << "$" << endl;
            if (catalog.Availability == 0)
                cout << "Magazine does not available in the shop now" << endl;
            else
            {
                cout << "Number of copies : " << catalog.Availability << endl;
            }
            cout << "------------------------------------" << endl;
        }
    }
    void Add_to_shop()
    {
        string syph;
        cout << "Enter sypher of book, or - : ";
        cin >> syph;
        for (int i = 0; i < In_shop.size(); ++i)
        {
            if (In_shop[i].Sypher == syph)
            {
                int t;
                cout << "Enter number of income : ";
                cin >> t;
                In_shop[i].Availability += t;
                return;
            }
        }
        int num, price;
        Add_magazine();
        cout << "Enter number of income : ";
        cin >> num;
        cout << "Enter price in shop : ";
        cin >> price;
        Catalog new_catalog(Magazines[Magazines.size() - 1], price, num);
        In_shop.push_back(new_catalog);
    }
    void Buy_from_shop()
    {
        string syph;
        int number;
        cout << "Enter sypher of the magazine" << endl;
        cin >> syph;

        for (auto &catalog : In_shop)
        {
            if (catalog.Sypher == syph)
            {
                cout << "Enter the number of purchased magazines" << endl;
                cin >> number;
                if (catalog.Availability < number)
                {
                    cout << "Not enough copies, you only bought" << catalog.Availability << " copies" << endl;
                    cout << "You should pay " << catalog.Availability * catalog.Price << "$" << endl;
                    Saled.push_back(catalog);
                    catalog.Availability = 0;
                }
                else
                {
                    cout << "You bought " << number << " copies" << endl;
                    cout << "You should pay " << catalog.Price * number << "$" << endl;
                    Saled.push_back(catalog);
                    Saled[Saled.size() - 1].Availability = number;
                    catalog.Availability -= number;
                }
            }
        }
        cout << "This sypher not found in shop" << endl;
    }

    void Get_sypher_by_name()
    {
        string fff;
        cout << "Enter name of magazine" << endl;
        cin >> fff;
        for (const auto &catalog : In_shop)
        {
            if (catalog.magazine.Name_mag == fff)
            {
                cout << catalog.Sypher << endl;
                return;
            }
        }
        cout << "No such magazine" << endl;
    }

    void Show_in_one_category()
    {
        cout << "Enter category of your magazine" << endl;
        string category;
        cin >> category;
        bool flag = 0;
        for (const auto &magazine : Magazines)
        {
            if (magazine.Category == category)
            {
                flag = 1;
                cout << magazine.Name_mag << "   " << magazine.Publishing << endl;
            }
        }
        if (flag == 0)
            cout << "No magazines in this category in out shop" << endl;
    }
    void Show_magazines_with_published()
    {
        map<string, vector<string>> res;
        for (const auto &magazine : Magazines)
        {
            res[magazine.Publishing].push_back(magazine.Name_mag);
        }
        for (const auto &t : res)
        {
            cout << t.first << " : ";
            for (const auto &tt : t.second)
            {
                cout << tt << " ";
            }
            cout << endl;
        }
    }
    void Most_popular_publisher()
    {
        map<string, int> sales;
        string result;
        int avail = 0;
        for (const auto &saled : Saled)
        {
            sales[saled.magazine.Publishing] += saled.Availability;
        }
        for (auto s : sales)
        {
            if (s.second > avail)
            {
                avail = s.second;
                result = s.first;
            }
        }
        cout << "Most popular publisher is " << result
             << ". It sold " << avail << " copies." << endl;
    }
    void Absent_books()
    {
        bool flag = 0;
        for (const auto &magazine : In_shop)
        {
            if (magazine.Availability == 0)
            {
                flag = 1;
                cout << "Magazine " << magazine.magazine.Name_mag << " is absent. It's sypher " << magazine.Sypher << endl;
                cout << "Please, bought it as soon as possible" << endl;
            }
        }
        if (flag == 0)
        {
            cout << "All magazines are available" << endl;
        }
    }
    void Total_profit()
    {
        double result = 0;
        for (const auto &sale : Saled)
        {
            result += sale.Availability * sale.Price;
        }
        cout << "Total profit equals " << result << "$" << endl;
    }

    void Load()
    {
        Magazines.clear();
        In_shop.clear();
        Saled.clear();
        LoadMagazines();
        LoadInShop();
        LoadSaled();
    }
    void Save()
    {
        SaveMagazines();
        SaveInShop();
        SaveSaled();
    }

    void LoadMagazines()
    {
        ifstream input("magazines.txt");
        int size, num;
        string name, categ, publish;
        input >> size;
        for (int i = 0; i < size; ++i)
        {
            input >> name >> categ >> publish >> num;
            Magazines.push_back(Magazine(name, categ, publish, num));
        }
    }
    void LoadInShop()
    {
        ifstream input("inshop.txt");
        int size, num, avail;
        string name, categ, publish;
        double price;
        input >> size;
        for (int i = 0; i < size; ++i)
        {
            input >> name >> categ >> publish >> num >> price >> avail;
            Magazine mag(name, categ, publish, num);
            In_shop.push_back(Catalog(mag, price, avail));
        }
    }
    void LoadSaled()
    {
        ifstream input("saled.txt");
        int size, num, avail;
        string name, categ, publish;
        double price;
        input >> size;
        for (int i = 0; i < size; ++i)
        {
            input >> name >> categ >> publish >> num >> price >> avail;
            Magazine mag(name, categ, publish, num);
            Saled.push_back(Catalog(mag, price, avail));
        }
    }

    void SaveMagazines()
    {
        ofstream output("magazines.txt");
        output << Magazines.size() << endl;
        for (const auto &magazine : Magazines)
        {
            output << magazine.Name_mag << endl;
            output << magazine.Category << endl;
            output << magazine.Publishing << endl;
            output << magazine.Num_of_pages << endl;
        }
    }
    void SaveInShop()
    {
        ofstream output("inshop.txt");
        output << In_shop.size() << endl;
        for (const auto &catalog : In_shop)
        {
            output << catalog.magazine.Name_mag << endl;
            output << catalog.magazine.Category << endl;
            output << catalog.magazine.Publishing << endl;
            output << catalog.magazine.Num_of_pages << endl;
            output << catalog.Price << endl;
            output << catalog.Availability << endl;
        }
    }
    void SaveSaled()
    {
        ofstream output("saled.txt");
        output << Saled.size() << endl;
        for (const auto &catalog : Saled)
        {
            output << catalog.magazine.Name_mag << endl;
            output << catalog.magazine.Category << endl;
            output << catalog.magazine.Publishing << endl;
            output << catalog.magazine.Num_of_pages << endl;
            output << catalog.Price << endl;
            output << catalog.Availability << endl;
        }
    }

    vector<Magazine> Magazines;
    vector<Catalog> In_shop;
    vector<Catalog> Saled;
};

void List()
{
    cout << "List of commands:" << endl;
    cout << "save           --- Save current shop in file" << endl;
    cout << "load           --- Load shop from file" << endl;
    cout << "new_magazine   --- Add new magazine to shop" << endl;
    cout << "show_magazines --- Show list of magazines in the shop" << endl;
    cout << "income         --- Add new batch of magazines" << endl;
    cout << "show_shop      --- Show which " << endl;
    cout << "get_sypher     --- Add new magazine to shop" << endl;
    cout << "buy            --- Buy some magazines" << endl;
    cout << "show_category  --- Show magazines in choosen category" << endl;
    cout << "publishers     --- Show publishers with their magazines" << endl;
    cout << "Most_popular   --- Show most popular publisher" << endl;
    cout << "Absent_magazines-- Show absent magazines in the store" << endl;
    cout << "Total_profit   --- Show total profit of the shop" << endl;
    cout << "stop           --- Stop the application" << endl;
}

int main()
{
    Shop db;
    string command;
    bool flag = 0;
    cout << "Hello, user!" << endl;
    List();

    cout << "Start working, enter first command" << endl;
    try
    {
        cin >> command;
        while (command != "stop")
        {
            flag = 0;
            if (command == "new_magazine")
            {
                db.Add_magazine();
                flag = 1;
            }
            if (command == "show_magazines")
            {
                db.Show_magazines();
                flag = 1;
            }
            if (command == "income")
            {
                db.Add_to_shop();
                flag = 1;
            }
            if (command == "show_shop")
            {
                db.Show_in_shop();
                flag = 1;
            }
            if (command == "get_sypher")
            {
                db.Get_sypher_by_name();
                flag = 1;
            }
            if (command == "buy")
            {
                db.Buy_from_shop();
                flag = 1;
            }
            if (command == "show_category")
            {
                db.Show_in_one_category();
                flag = 1;
            }
            if (command == "publishers")
            {
                db.Show_magazines_with_published();
                flag = 1;
            }
            if (command == "Most_popular")
            {
                db.Most_popular_publisher();
                flag = 1;
            }
            if (command == "Absent_magazines")
            {
                db.Absent_books();
                flag = 1;
            }
            if (command == "Total_profit")
            {
                db.Total_profit();
                flag = 1;
            }
            if (command == "save")
            {
                db.Save();
                flag = 1;
            }
            if (command == "load")
            {
                db.Load();
                flag = 1;
            }
            if (flag == 0)
                cout << "Unknown command" << endl;
            system("pause");
            clear();
            List();
            cout << "Enter new command" << endl;
            cin >> command;
        }
    }
    catch (exception &ex)
    {
        cout << "Exception happens";
    }
}
