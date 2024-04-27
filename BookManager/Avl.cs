using System;
using System.ComponentModel.Design;
using BookManager._1_Modulo1;


public class Tdata
{
    public int id;
    public string bookTitle;
    public string author;
    public DateTime pubDate;
}

public class Node
{
    public Tdata data =  new Tdata();
    public Node left, right;
    public int height;

    public Node(Tdata d)
    {
        data = d;
        height = 1;
    }
}

public class AVLTree
{
    public Node root;

    int height(Node N)
    {
        if (N == null)
            return 0;
        return N.height;
    }
    int max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    Node rightRotate(Node y)
    {
        Node x = y.left;
        Node T2 = x.right;

        x.right = y;
        y.left = T2;

        y.height = max(height(y.left), height(y.right)) + 1;
        x.height = max(height(x.left), height(x.right)) + 1;

        return x;
    }

    Node leftRotate(Node x)
    {
        Node y = x.right;
        Node T2 = y.left;

        y.left = x;
        x.right = T2;

        x.height = max(height(x.left), height(x.right)) + 1;
        y.height = max(height(y.left), height(y.right)) + 1;

        return y;
    }
    int getBalance(Node N)
    {
        if (N == null)
            return 0;
        return height(N.left) - height(N.right);
    }


    public Node insert(Node node, Tdata data)
    {
        if (node == null)
            return new Node(data);

        if (data.id < node.data.id)
            node.left = insert(node.left, data);
        else if (data.id > node.data.id)
            node.right = insert(node.right, data);
        else
            return node;


        node.height = 1 + max(height(node.left),
                              height(node.right));


        int balance = getBalance(node);
        if (balance > 1 && data.id < node.left.data.id)
            return rightRotate(node);
        if (balance < -1 && data.id > node.right.data.id)
            return leftRotate(node);
        if (balance > 1 && data.id > node.left.data.id)
        {
            node.left = leftRotate(node.left);
            return rightRotate(node);
        }
        if (balance < -1 && data.id < node.right.data.id)
        {
            node.right = rightRotate(node.right);
            return leftRotate(node);
        }
        return node;
    }

    // Função travessia em ordem
    public void inorder(Node node)
    {
        if (node != null)
        {
            inorder(node.left);
            //SaveInTXT.WriteTXT(node.data);
            inorder(node.right);
        }
    }

    public Node balance(Node node)
    {
        int balanceFactor = getBalance(node);
        if (balanceFactor > 1)
        {
            if (getBalance(node.left) >= 0)
            {
                return rightRotate(node);
            }
            else
            {
                node.left = leftRotate(node.left);
                return rightRotate(node);
            }
        }
        else if (balanceFactor < -1)
        {
            if (getBalance(node.right) <= 0)
            {
                return leftRotate(node);
            }
            else
            {
                node.right = rightRotate(node.right);
                return leftRotate(node);
            }
        }
        return node;
    }


    public Node deleteNode(Node root, int key)
    {
        if (root == null)
            return root;
        if (key < root.data.id)
            root.left = deleteNode(root.left, key);
        else if (key > root.data.id)
            root.right = deleteNode(root.right, key);
        else
        {
            if ((root.left == null) || (root.right == null))
            {
                Node temp = null;
                if (temp == root.left)
                    temp = root.right;
                else
                    temp = root.left;


                if (temp == null)
                {
                    temp = root;
                    root = null;
                }
                else
                    root = temp;
            }
            else
            {
                Node temp = minValueNode(root.right);
                root.data = temp.data;
                root.right = deleteNode(root.right, temp.data.id);
            }
        }
        if (root == null)
            return root;
        root.height = 1 + max(height(root.left), height(root.right));
        int balance = getBalance(root);
        if (balance > 1 && getBalance(root.left) >= 0)
            return rightRotate(root);
        if (balance > 1 && getBalance(root.left) < 0)
        {
            root.left = leftRotate(root.left);
            return rightRotate(root);
        }
        if (balance < -1 && getBalance(root.right) <= 0)
            return leftRotate(root);
        if (balance < -1 && getBalance(root.right) > 0)
        {
            root.right = rightRotate(root.right);
            return leftRotate(root);
        }
        return root;
    }

    Node minValueNode(Node node)
    {
        Node current = node;
        while (current.left != null)
            current = current.left;
        return current;
    }

    public void printTree(Node root, string indent, bool last)
    {
        if (root != null)
        {
            //CadBooks.arvore += indent;
            if (last)
            {
                //CadBooks.arvore += "└─";
                indent += "  ";
            }
            else
            {
               //CadBooks.arvore += "├─";
                indent += "| ";
            }
            //CadBooks.arvore += root.data.id.ToString() + " - " + root.data.bookTitle + "\n";

            printTree(root.left, indent, false);
            printTree(root.right, indent, true);
        }
    }

    public int getRootBalanceFactor()
    {
        if (root == null)
        { return 0; }
        else
        { return getBalance(root); }
    }

    public Node Search(Node root, int key)
    {
        if (root == null || root.data.id == key)
            return root;
        if (root.data.id < key)
            return Search(root.right, key);
        return Search(root.left, key);
    }
}
