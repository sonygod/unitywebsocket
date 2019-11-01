/*
 * @Author: delevin.ying 
 * @Date: 2019-05-14 10:33:16 
 * @Last Modified by:   delevin.ying 
 * @Last Modified time: 2019-05-14 10:33:16 
 */
public class CEvent {
    public string eventName; //事件名称
    public object eventParams; //事件传的参数
    public object target; //事件抛出者

    public CEvent (string name, object p= null) {
        this.eventName = name;
        this.eventParams = p;
    }
}