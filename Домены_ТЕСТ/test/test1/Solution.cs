using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace test1
{
    class Solution
    {


          ////////////////////////////////////////////
        public static string TreeList(string domen1, int s) //получает домен из массива В, выводит зону домена(s номер зоны с конца s=0)
        {
            int l =0;// количество точек в имени домена(начинается с 1)
            string treeDomen=null;
            int i2 = domen1.Length - 1;
            int r = domen1.Length - 1;
           while (l!=s+1 )
            {
                if(r<0) break;
                if (domen1[r] == '.' )
                {
                    
                    l++;//количество точек                     
                }
                r--;//индекс точки
             }
                    if(r<0)
                    { i2 = 0; }
                    else{
                    i2 = r+2;
                    }
                    while (domen1[i2] != '.')
                    {
                        if (treeDomen == null)
                        {
                            char[] chr = {domen1[i2]}; 
                            string txt = new string(chr);      
                            treeDomen =txt;
                        }
                        else
                        {
                            treeDomen = treeDomen+domen1[i2];
                        }
                        i2 = i2+ 1;
                        if (i2 == domen1.Length)
                        {
                            break;
                        }
                    }
                           
            return treeDomen;
        }


          
             /////////////////////////////////////////////          
        public static ANode TreeDomen(string[] B)//создаёт дерево доменов
        {
            ANode treeDomen = new ANode();//дерево доменов
           // int count1;
            string str;
            for (int i = 0; i < B.Length; i++)//перебираем массив В
            {

                str = Solution.TreeList(B[i], 0);    //нулевая зона домена B[i]
            
                treeDomen.Insert(str, B[i], treeDomen);
            }

          return treeDomen;
        }

        ///////////////////////////////////
        //сравнение домена и хоста, является ли хост поддоменом
        public static bool eq(string host, string domen)
        {
            bool fl6 = false;
            //int countHost = 0;
            //int countDomen = 0;
            if (host.Length < domen.Length)
            {
                fl6 = false;
                return fl6;
            }
            int i4= host.Length;
            for (int i3 = domen.Length-1; i3 >= 0; i3--)
            {
                i4--;
                int result = String.Compare(host[i4].ToString(), domen[i3].ToString());
                string s = host[i4].ToString();
                string s2 = domen[i3].ToString();
                if (result!=0)
                {
                    fl6 = false;
                    return fl6;;
                }
                else
                {
                    fl6 = true;
                }
                
            }
            if(i4==0)
            {
                fl6=true;
                return fl6;
            }
            if (host[i4 - 1] == '.')
            {
                fl6 = true;
                return fl6;
            }
            else
            {
                fl6 = false;
                return fl6;
            }
        }



        //////////////////////////////////////////////
        //str проверяемый хост, ptr проверяемый узел дерева, depth номер зоны, l глубина дерева
        public static bool l_tree(string str, ANode ptr, int depth, int l = 0)  // 
        {

            ArrayList AList;
            bool fl = false;
            bool fl2 = false;
            string  str1=TreeList(str, depth);


           int count1 = 0;//количество точек в домене A[i]-- количество зон = count1+1           
                for (int i3 = 0; i3 < str.Length; i3++)
            {
                if (str[i3] == '.')
                {
                    count1++;
                }
            }


            // .... перебираем ключи в словаре узла дерева доменов
            foreach (string str3 in ptr.tree1.Keys)
            {
                if (str1 == str3)//ищем совпадение зоны c ключом
                {
                    fl = true; //нашли совпадение 
                    break;
                }
                else
                {
                    fl = false;
                }
            }
            
   

            if (fl == true)//если есть ключ совпадающий с зоной хоста
            {
                AList = ptr.tree1[str1]; //получение списка доменов по ключу str1
                str1 = TreeList(str, depth + 1);//переход к следующей зоне хоста A[i]

     

                ////////....сначала проверяем все строки из списка узла текущего ключа, если хост подддомен то дальше не проверяем
                foreach (object o in AList)  /////Получаем объекты из дерева доменов в узле по предыдущему ключу str1
                {
                    var c = o.GetType();
                    bool ff = c.Equals(typeof(ANode));
                    
                         if (ff == false)//если объект - строка (домен)
                         {
                             string str5;
                             str5=(string)o;
                              bool result = eq(str, str5);
                             if (result==true)
                             {
                                 fl = true;
                                 return fl;
                             }
                          }
                }

                /////...если в строках не найдено домена ищем  дальше в словарях узлов.
                ANode node2 = new ANode();
                foreach (object o in AList)  /////Получаем объекты из дерева доменов в узле по предыдущему ключу str1
                {
                    var c = o.GetType();
                    bool ff = c.Equals(typeof(ANode));
                        if (ff == true)//если объект не строка(не домен)
                        {
                            fl2 = false;
                            ANode N = new ANode();
                            N = (ANode)o;
                            foreach (string st in N.tree1.Keys)//перебираем ключи в следующем узле 
                            {
                                int result = String.Compare(str1, st);

                                if (result==0)
                                {
                                    node2 = N;
                                    fl2 = true;
                                    break;
                                }
                            }
                            if (fl2 == true)
                            {
                                fl = fl2;
                                break;
                            }
                        }
                    
                }




                if (fl == true)
                {
                  fl=  l_tree(str, node2, depth + 1, l + 1);
                }



            }
            return fl;
        }






        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] solution(string[] A, string[] B)
        {
            int[] L=new int[0];      //массив выходных значений
            int lengthMassA = A.Length;  //длина массива А
            int lengthMassB = B.Length;  //длина массива В
            bool fl; //указывает заблокирован хост или нет
            ANode domenTree;//Массив деревьев доменов
            int count1;
            string str;
            //ArrayList AList;
            domenTree=TreeDomen(B);//строим  деревo доменов В

 


            for (int i = 0; i < lengthMassA; i++)  //обход массива хостов А
            {
                count1 = 0;//количество точек в домене A[i]-- количество зон = count1+1
                fl = false;// указывает заблокирован хост или нет
                for (int i3 = 0; i3 < A[i].Length; i3++)
                {
                    if (A[i][i3] == '.')
                    {
                        count1++;
                    }
                }


                fl = l_tree(A[i], domenTree, 0);//проверка на блокировку хоста A[i]
 

                if (fl == false)//хост не заблокирован
                {
                    Array.Resize(ref L, L.Length + 1);

                    L[L.Length - 1] = i;
                }

            }//конец цикла обход массива хостов А

           // Array.Resize(ref L, L.Length + 1);
           
            return L;
        }
    }
}
