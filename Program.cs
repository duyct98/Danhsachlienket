

using source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Node Head;
            // tao node 1
            Node node1 = new Node(1, null);
            Head = node1;

            //tao node 2 lien ket node 1 vao node 2
            Node node2 = new Node(2, null);
            node1.next = node2;


            // them node vao giua
            Node node3 = new Node(3, null);
            node1.next = node3;
            node3.next = node2;

            // them node vao dau
            Node node4 = new Node(4, null);
            node4.next = Head;
            Head = node4;
            void themNodeDau()
            {
                Console.Write("Nhap DATA node = ");
                int data = Convert.ToInt32(Console.ReadLine());
                Node node10 = new Node(data, null);
                node10.next = Head;
                Head = node10;
                Console.Write("DSLK sau khi them Node: ");
                xuatDS();
            }
            void themNodeCuoi()
            {
                Console.Write("Nhap DATA node = ");
                int data = Convert.ToInt32(Console.ReadLine());
                Node node10 = new Node(data, null);
                Node t = Head;



                while (t.next != null)
                {

                    t = t.next;
                }
                t.next = node10;
                Console.Write("DSLK sau khi them Node: ");

                xuatDS();
            }
            void themNode()
            {
                Console.Write("Chon vi tri them Node(1: Vi tri dau -- 0: vi tri cuoi): ");
                int vitri = Convert.ToInt32(Console.ReadLine());
                if (vitri == 1)
                {
                    themNodeDau();

                }
                if (vitri == 0)
                {
                    themNodeCuoi();
                }
            }
            void xoaPhanTu()
            {
                Console.Write("Nhap phan tu muon xoa :");
                int x = Convert.ToInt32(Console.ReadLine());
                Node e = Head.next;
                Node w = Head;
                while (e != null)
                {
                    if (x == Head.data)
                    {
                        Head = e;

                    }
                    else if (x == e.data)
                    {
                        w.next = e.next;

                    }
                    e = e.next;
                    w = w.next;


                }
            }
            // in gia tri trong dnah sach lien ket
            Node p = Head;
            void menu()
            {
                Console.WriteLine("=============  MENU  ================ \n");
                Console.Write("DS lien ket hien tai: ");
                xuatDS();
                Console.WriteLine("1. In DSLK");
                Console.WriteLine("2. Them phan tu vao DSLK");
                Console.WriteLine("3. Xoa phan tu dau tien.");
                Console.WriteLine("4. Xoa phan tu cuoi cung.");
                Console.WriteLine("5. Tim phan tu X trong DSLK.");
                Console.WriteLine("6. Xoa phan tu X khoi DSLK.");
                Console.WriteLine("7. Tim phan tu lon nhat trong DSLK.");
                Console.WriteLine("8. Xoa man hinh");
                Console.WriteLine("0. EXIT.");

            }
            void xuatDS()
            {
                p = Head;
                while (p != null)
                {
                    Console.Write(p.data);
                    Console.Write(" ");
                    p = p.next;


                }
                Console.Write("\n\n");

            }
            void timMax()
            {
                int max = Head.data;
                p = Head;
                while (p != null)
                {
                    if (p.next != null)
                    {
                        if (max < p.next.data)
                        {
                            max = p.next.data;

                        }
                    }

                    p = p.next;


                }
                Console.WriteLine("Phan tu lon nhat : {0}", max);


            }

            void XoaPhanTuDau()
            {
                if (Head == null)
                {
                    Console.WriteLine("Khong co phan tu nao de xoa !!!");

                }
                else
                    Head = Head.next;
            }
            void XoaPhanTuCuoi()
            {

                if (Head == null)
                {
                    Console.WriteLine("Khong co phan tu nao de xoa !!!");

                }
                else
                {


                    p = Head;
                    Node t = Head.next;
                    if (Head.next == null)
                    {
                        Head = null;

                    }
                    else
                    {
                        while (t.next != null)
                        {

                            p = p.next;
                            t = t.next;


                        }

                        p.next = null;
                    }


                }


            }
            void timphantu()
            {
                Console.Write("Nhap phan tu can tim: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int check = 0, dem = 0;
                p = Head;
                while (p != null)
                {

                    if (x == p.data)
                    {

                        check = 1;

                    }

                    p = p.next;

                }
                if (check == 1)
                {

                    Console.Write("Co phan tu {0} trong DSLK vi tri:", x);
                    p = Head;
                    while (p != null)
                    {
                        dem++;
                        if (x == p.data)
                        {
                            Console.Write(" {0}", dem);
                        }
                        p = p.next;
                    }
                    Console.Write("\n");
                }
                else
                    Console.WriteLine("Khong Co phan tu {0} trong DSLK", x);
            }



            int luachon;
            menu();
            do
            {

                Console.Write("-----------------------\nNhap lua chon cua ban ( 0 - 9 ): ");
            luaChonLai:
                luachon = Convert.ToInt32(Console.ReadLine());
                if (luachon >= 0 && luachon < 10)
                {

                }
                else
                {
                    Console.Write("\nNhap lai lua chon ( 0 - 9 ) : ");
                    goto luaChonLai;
                }
                Console.Write("\n-----------------------\n");

                switch (luachon)
                {
                    case 1:
                        xuatDS();
                        break;
                    case 2:
                        themNode();

                        break;
                    case 3:
                        XoaPhanTuDau();

                        break;
                    case 4:
                        XoaPhanTuCuoi();

                        break;
                    case 5:
                        timphantu();
                        break;
                    case 6:
                        xoaPhanTu();
                        break;
                    case 7:
                        timMax();
                        break;
                    case 8:

                        Console.Clear();
                        menu();
                        break;
                    case 9:
                        int soluongnode = Convert.ToInt32(Console.ReadLine());
                        while (soluongnode != 0)
                        {
                            soluongnode--;
                            themNodeCuoi();
                        }

                        break;
                }
            }
            while (luachon != 0);

            Console.ReadKey();


        }
    }
}
