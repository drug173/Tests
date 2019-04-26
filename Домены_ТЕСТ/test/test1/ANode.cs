using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace test1
{
   public class ANode
    {
       public  Dictionary<string, ArrayList> tree1 = new Dictionary<string, ArrayList>();


       // dataZone -вставляемая зона домена В[i],  dataDomen- вставляемый домен B[i]
       public void Insert(string dataZone, string dataDomen, ANode node, int depth = 0)// вставка в дерево  зоны домена. depth глубина вставки
       {
           int count1 = 0;//количество точек в домене B[i]
           string str2;
           bool fl;
           ArrayList  treeList2 = new ArrayList(); ;
           ArrayList list2;
           bool fl2 = false;

           for (int i3 = 0; i3 < dataDomen.Length; i3++)
           {
               if (dataDomen[i3] == '.')
               {
                   count1++;
               }
           } 


           if (tree1.Count == 0)//если записей нет
           {
             
               //node.tree1 = new Dictionary<string, ArrayList>();
               
           
               if (count1-depth == 1)  //если во вставляемом домене только две зоны, то в значение словаря вставляем домен
               {
                   treeList2.Add(dataDomen);
               } 
               else
               {
                   str2=Solution.TreeList(dataDomen,depth+1);//следующая вставляемая зона
                   ANode node2 = new ANode();
                   Insert(str2, dataDomen, node2, depth + 1);

                   treeList2.Add(node2);
               }
               node.tree1.Add(dataZone, treeList2);
               return;
           }
           else
           {
               //.....находим совпадение с ключом ---если есть совпадение нужно искать в следующей зоне совпадение ключей
               //////////////////////////////////////////////////////////////////////////////////////////////////////////////

               fl = false;
               foreach (string c in node.tree1.Keys)
               {
                   if (dataZone == c)
                   {
                       fl = true;

                       break;
                   }
               }
               if (fl == false)
               {
                   //node.tree1 = new Dictionary<string, ArrayList>();
                   if (count1 - depth == 1)  //если во вставляемом домене только две зоны, то в значение словаря вставляем домен
                   {
                       treeList2.Add(dataDomen);

                   }
                   else
                   {
                       str2 = Solution.TreeList(dataDomen, depth + 1);//следующая вставляемая зона
                       ANode node2 = new ANode();
                       Insert(str2, dataDomen, node2, depth + 1);

                       treeList2.Add(node2);

                   }
                   node.tree1.Add(dataZone, treeList2);
                   return;

               }
               else
               {

                   if (count1 - depth == 1)  //если во вставляемом домене только две зоны, то в значение словаря вставляем домен
                   {
                       list2 = node.tree1[dataZone];
                       node.tree1.Remove(dataZone);
                       list2.Add(dataDomen);
                 

                   }
                   else
                   {
                       str2 = Solution.TreeList(dataDomen, depth + 1);//следующая вставляемая зона
                       ANode node2 = new ANode();
                       list2 = node.tree1[dataZone];//////////получение списка доменов по ключу 

                       foreach (object o in list2)
                       {
                          var c= o.GetType();
                           bool ff= c.Equals(typeof(ANode));
                           if (ff == true)
                           {
                               fl2 = false;
                               ANode N=new ANode();
                               N = (ANode)o;
                               foreach (string st in N.tree1.Keys)
                               {
                                   if (str2 == st)
                                   {
                                       node2 = N;
                                       fl2 = true;
                                       break;
                                   }
                               }
                               if (fl2 == true) { break; }
                           }

                       }

                      
                       Insert(str2, dataDomen, node2, depth + 1);

                       //list2 = node.tree1[dataZone];
                       node.tree1.Remove(dataZone);
                       if (fl2 == false)
                       {
                           list2.Add(node2);
                       }
                   }
                   node.tree1.Add(dataZone, list2);
                   return;

               }

       

              
           }
       }




 

    }

}
