/*
 * @Author: delevin.ying 
 * @Date: 2019-05-14 10:33:34 
 * @Last Modified by:   delevin.ying 
 * @Last Modified time: 2019-05-14 10:33:34 
 */
using UnityThreading;
public class CEventListener {
    public CEventListener () { }
    //委托
    public delegate void CEventListenerDelegate (CEvent evt);

    public event CEventListenerDelegate OnEvent;

    public void Excute (CEvent evt) {
        if (OnEvent != null)
        {

            UnityThreadHelper.Dispatcher.Dispatch(() =>
            {
                OnEvent(evt);
            });
          
        }
    }
}