﻿using System.Net.Sockets;

namespace FastNetwork
{
    /// <summary>
    /// socketAsyncEventArgs pool interface
    /// </summary>
    public interface ISAEAPool
    {
        /// <summary>
        /// get
        /// </summary>
        /// <returns></returns>
        SocketAsyncEventArgs GetSocketAsyncEventArgs();
        /// <summary>
        /// release
        /// </summary>
        /// <param name="e"></param>
        void ReleaseSocketAsyncEventArgs(SocketAsyncEventArgs e);
    }
}