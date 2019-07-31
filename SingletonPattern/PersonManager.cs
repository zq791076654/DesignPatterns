using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class PersonManager
    {
        private PersonManager()
        { }

        #region 通过判断私有变量是否为空实现单例
        private static PersonManager personManager;

        #region 单线程版本
        //public static PersonManager GetPersonManager()
        //{
        //    if (personManager == null)
        //    {
        //        personManager = new PersonManager();
        //    }
        //    return personManager;
        //}
        #endregion

        #region 多线程版本
        //private static readonly object locker = new object();
        //public static PersonManager GetPersonManager()
        //{
        //    lock (locker)
        //    {
        //        if (personManager == null)
        //        {
        //            personManager = new PersonManager();
        //        }
        //    }
        //    return personManager;
        //}
        #endregion

        #region 双重锁定
        private static readonly object locker = new object();
        public static PersonManager GetPersonManager()
        {
            //先检查是否已经存在，而不是每次都先加锁，提高效率
            if (personManager == null)
            {
                //不存在再加锁
                lock (locker)
                {
                    //如果实例不存在则创建，之所以要再判断一遍，
                    //有可能在上一步判断后加锁的过程中，其他线程已经持有了锁进行的创建实例的操作
                    if (personManager == null)
                    {
                        personManager = new PersonManager();
                    }
                }
            }
            return personManager;
        }
        #endregion 
        #endregion

        #region 使用直接初始化静态变量实现单例

        #region 直接实例化,线程安全但是没有延迟加载
        //private static PersonManager personManager = new PersonManager();
        //public static PersonManager GetPersonManager()
        //{
        //    return personManager;
        //}
        #endregion

        #region 内部类的方式实例化,线程安全且延迟加载
        //private static class SingletonHolder
        //{
        //    public readonly static PersonManager INSTANCE = new PersonManager();
        //}

        //public static PersonManager GetPersonManager()
        //{
        //    return SingletonHolder.INSTANCE;
        //}
        #endregion
        #endregion


        public void Say()
        {
            Console.WriteLine("PersonManager");
            Console.ReadKey();
        }

    }


}
