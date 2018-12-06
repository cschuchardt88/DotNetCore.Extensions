using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class ErrorExceptionHandlingExtension
    {
        /// <summary>
        /// Adds try catch to an object.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        public static void TryCatch<TSource>(this TSource anonymousObjectType, Action<TSource> execAction)
        {
            try
            {
                execAction(anonymousObjectType);
            }
            catch
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        public static void TryCatch<TSource>(this TSource anonymousObjectType, Action<TSource> execAction, Action<TSource> exeCatchAction)
        {
            try
            {
                execAction(anonymousObjectType);
            }
            catch
            {
                exeCatchAction(anonymousObjectType);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        public static void TryCatch<TSource, TException>(this TSource anonymousObjectType, Action<TSource> execAction, Action<TSource> exeCatchAction)
        {
            try
            {
                execAction(anonymousObjectType);
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(TException))
                    exeCatchAction(anonymousObjectType);
            }
        }

        /// <summary>
        /// Adds try catch to an object.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        /// <returns>returns the TResult type from the function. If fails returns an empty TResult.</returns>
        public static TResult TryCatch<TSource, TResult>(this TSource anonymousObjectType, Func<TSource, TResult> execAction)
        {
            try
            {
                return execAction(anonymousObjectType);
            }
            catch
            {
            }

            return default(TResult);
        }

        /// <summary>
        /// Adds try catch to an object. Also throws an exception if an exception occures.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        public static void TryCatchThrow<TSource>(this TSource anonymousObjectType, Action<TSource> execAction)
        {
            try
            {
                execAction(anonymousObjectType);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Adds try catch to an object. Also throws an exception if an exception occures.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        /// <returns></returns>
        public static TResult TryCatchThrow<TSource, TResult>(this TSource anonymousObjectType, Func<TSource, TResult> execAction)
        {
            try
            {
                return execAction(anonymousObjectType);
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// Adds try catch to an object. Also throws an exception if an exception occures.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        /// <param name="exeFinally"></param>
        public static void TryCatchThrowFinally<TSource>(this TSource anonymousObjectType, Action<TSource> execAction, Action<TSource> exeFinally)
        {
            try
            {
                execAction(anonymousObjectType);
            }
            catch
            {
                throw;
            }
            finally
            {
                exeFinally(anonymousObjectType);
            }
        }

        /// <summary>
        /// Adds try catch to an object. Also throws an exception if an exception occures.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        /// <param name="exeFinally"></param>
        /// <returns></returns>
        public static TResult TryCatchThrowFinally<TSource, TResult>(this TSource anonymousObjectType, Func<TSource, TResult> execAction, Action<TSource> exeFinally)
        {
            try
            {
                return execAction(anonymousObjectType);
            }
            catch
            {
                throw;
            }
            finally
            {
                exeFinally(anonymousObjectType);
            }
        }

        /// <summary>
        /// Adds try catch to an object.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        /// <param name="exeFinally"></param>
        public static void TryCatchFinally<TSource>(this TSource anonymousObjectType, Action<TSource> execAction, Action<TSource> exeFinally)
        {
            try
            {
                execAction(anonymousObjectType);
            }
            catch
            {
            }
            finally
            {
                exeFinally(anonymousObjectType);
            }
        }

        /// <summary>
        /// Adds try catch to an object.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="anonymousObjectType"></param>
        /// <param name="execAction"></param>
        /// <param name="exeFinally"></param>
        /// <returns></returns>
        public static TResult TryCatchFinally<TSource, TResult>(this TSource anonymousObjectType, Func<TSource, TResult> execAction, Action<TSource> exeFinally)
        {
            try
            {
                return execAction(anonymousObjectType);
            }
            catch
            {
            }
            finally
            {
                exeFinally(anonymousObjectType);
            }

            return default(TResult);
        }
    }
}

