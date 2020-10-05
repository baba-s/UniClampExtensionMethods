# UniClampExtensionMethods

Mathf.Clamp、Mathf.Max、Mathf.Min を拡張メソッドで呼び出せるようにするパッケージ

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        int i = 25;

        Debug.Log( i.Clamp( 0, 100 ) );
        Debug.Log( i.Max( 100 ) );
        Debug.Log( i.Min( 0 ) );

        float f = 25f;

        Debug.Log( f.Clamp01() );
        Debug.Log( f.Clamp( 0, 100 ) );
        Debug.Log( f.Max( 100 ) );
        Debug.Log( f.Min( 0 ) );
    }
}
```
