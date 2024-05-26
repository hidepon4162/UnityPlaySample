using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // プレイヤーの移動速度

    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized; // 入力された方向を正規化して移動ベクトルを作成
        Move(movement); // プレイヤーを移動させる
    }

    private void Move(Vector2 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime); // 方向に応じてプレイヤーを移動させる
    }
}