using System;
using System.IO;

namespace CascadingExceptionHandling
{
    /*
   we have 5 methods m1 m2 m3 m4 m5 , and m1 call m2 ,m2 calls m3 like that upto m4 call m5 ,but when exception 
   occure in m5 we must catch in m4 ,when exception occure in m4 we must catch in m3 
     */
    class Program
    {
        static void Main(string[] args)
        {
            void m1()
{
                try
                {
                    m2();
                }
                catch (IOException ex)
                {
                }
            }
            void m2()
{
                try
                {
                    m3();
                }
                catch (Exception ex)
                {
                }
            }
           void  m3()
{
                try
                {
                    m4();
                }
                catch (Exception ex)
                {
                }
            }
            void m4()
{
                try
                {
                    m5();
                }
                catch (Exception ex)
                {
                }
            }

            void m5()
            {
                try
                {
                    //m5();
                }
                catch (Exception ex)
                {
                }

            }
        }
    }
}
