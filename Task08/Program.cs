// Обход выражения: ((4-2)*(1+3)) / 10. Это бинарное дерево.

string emp = string.Empty;
string [] tree = {emp, "/","*","10","-","+",emp, emp,"4", "2","1","3" };
//                0    1    2   3    4   5   6    7   8    9   10  11
void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2*pos;
        int right = 2*pos + 1;
        if(left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]); // позицию Console.WriteLine можно менять, от этого вывод буде разным.
        if(right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        
    }
}
InOrderTraversal();
