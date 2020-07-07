#include<iostream>
#include<iomanip>
#include<vector>
#include<algorithm>
#include<fstream>
#include<list>
#include<iterator>
using namespace std;

class Graph
{
private:
    const int inf = 9999;
public:
    vector<pair<pair<int, int>, int>> MST;
    int size;
    list<int>MST_l;
    vector<vector<int>> g;
    Graph(int);
    void Print();
    void Kruskal();
    void MST_p();
    void Prim();
    void MST_prim();
    void Dijkstra(int n);
};
Graph::Graph(int si)
{
    size = si;
    for (int i = 0; i < si; i++)
    {
        g.push_back(vector<int>());
        for (int j = 0; j < si; j++)
        {
            g[i].push_back(inf);
        }
    }
    int t;
    for (int i = 0; i < si; i++)
    {
        for (int j = i + 1; j < si; j++)
        {
            cout << "Ребро между вершиной " << i + 1 << " и " << j + 1 << " ";
            cin >> t;
            if (t)
            {
                g[i][j] = g[j][i] = t;
            }
        }
    }

}
void Graph::Print()
{

    for (int i = 0; i < g[0].size(); i++)
    {
        for (int j = 0; j < g[0].size(); j++)
        {
            if (g[i][j] == inf)cout << "&&" << " ";
            else cout << g[i][j] << " ";
        }
        cout << '\n';
    }
}
void Graph::Kruskal()
{
    MST.clear();
    vector<int> B;
    for (int i = 1; i <= size; i++)
    {
        B.push_back(i);
    }
    int min = inf, f = 0, s = 0;
    for (int t = 1; t < size; t++)
    {
        min = inf;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (g[i][j] < min && B[i] != B[j])
                {
                    f = i;
                    s = j;
                    min = g[i][j];
                }
            }
        }
        for (int j = 0; j < size; j++)
        {
            if (B[j] == B[s])B[j] = B[f];
        }
        MST.push_back(make_pair(make_pair(f, s), min));
    }
}
void Graph::MST_p()
{
    vector<int> B(size, 0);
    int beg = 1, it = -1;
    for (int i = 0; i < MST.size(); i++)
    {
        B[MST[i].first.first]++;
        B[MST[i].first.second]++;
    }
    for (int i = 0; i < B.size(); i++)
    {
        if (B[i] == 1)
        {
            beg = i;
            break;
        }
    }
    for (int j = 0; j < MST.size(); j++)
    {
        for (int i = 0; i < MST.size(); i++)
        {
            if (beg == MST[i].first.first && i != it)
            {
                cout << MST[i].first.first + 1 << "->" << MST[i].first.second + 1 << " Вес перехода:" << MST[i].second << '\n';
                beg = MST[i].first.second;
                it = i;
                break;
            }
            else
            {
                if (beg == MST[i].first.second && i != it)
                {
                    cout << MST[i].first.second + 1 << "->" << MST[i].first.first + 1 << " Вес перехода:" << MST[i].second << '\n';
                    beg = MST[i].first.first;
                    it = i;
                    break;
                }
            }
        }
    }
    cout << '\n';
}
void Graph::Prim()
{
    MST.clear();
    vector<int> B(size, 0);
    B[0] = 1;
    MST_l.push_back(1);
    int beg = 0, min = inf, f = 0, s = 0;
    for (int i = 1; i < size; i++)
    {
        min = inf;
        for (int j = 0; j < size; j++)
        {
            if (g[beg][j] < min && B[j] == 0)
            {
                f = beg;
                s = j;
                min = g[beg][j];
            }
        }
        B[s] = 1;
        MST_l.push_back(s + 1);
        beg = s;
    }


}
void Graph::MST_prim()
{
    auto iter = MST_l.begin();
    vector<vector<int>> Rez;
    cout << "Список: \n";
    cout << *iter;
    iter++;
    for (iter; iter != MST_l.end(); iter++)
    {
        cout << "->" << *iter;
    }
    cout << '\n';
    for (int i = 0; i < MST_l.size(); i++)
    {
        Rez.push_back(vector<int>());
        for (int j = 0; j < MST_l.size(); j++)
        {
            Rez[i].push_back(inf);
        }
    }
    iter = MST_l.begin();
    int p = *iter;
    iter++;
    int cer = *iter;
    while (iter != MST_l.end())
    {
        Rez[p - 1][cer - 1] = Rez[cer - 1][p - 1] = g[p - 1][cer - 1];
        iter++;
        if (iter == MST_l.end())break;
        p = cer;
        cer = *iter;
    }
    cout << "Матрица: \n";
    for (int i = 0; i < MST_l.size(); i++)
    {
        for (int j = 0; j < MST_l.size(); j++)
        {
            if (Rez[i][j] == inf)cout << "&&" << " ";
            else cout << Rez[i][j] << " ";
        }
        cout << endl;
    }
}
void Graph::Dijkstra(int n)
{
    n--;
    int mi, in = 0;
    vector<int> D, B(size, 0);
    B[n] = 1;
    for (int i = 0; i < size; i++)
    {
        D.push_back(g[n][i]);
    }
    for (int j = 1; j < size; j++)
    {
        mi = inf;
        for (int i = 0; i < size; i++)
        {
            if (B[i] == 0 && D[i] < mi)
            {
                in = i;
                mi = D[i];
            }
        }
        B[in] = 1;
        for (int i = 0; i < size; i++)
        {
            D[i] = min(D[i], g[i][in] + D[in]);
        }
    }
    cout << "Кратчайший пусть из вершины " << n + 1 << " В вершины с 1 по " << size << '\n';
    for (int i = 0; i < size; i++)
    {
        if (i == n)cout << inf << " ";
        else cout << D[i] << " ";
    }
    cout << '\n';
}
int main()
{
    setlocale(LC_ALL, "Russian");
    int n, k;
    cout << "Ведите кол-во вершин графа ";
    cin >> n;
    cout << "Ведите вес ребер, если ребра нет, введите 0 \n";
    Graph MyG(n);
    cout << "Граф в виде матрицы: \n";
    MyG.Print();
    cout << " \nАлгоритм_Краскала \n";
    MyG.Kruskal();
    MyG.MST_p();
    cout << "Алгоритм_Прима \n";
    MyG.Prim();
    MyG.MST_prim();
    cout << "Введите номер вершины, для которой хотите запустить алгоритм Дейкстры:";
    cin >> k;
    MyG.Dijkstra(k);
}