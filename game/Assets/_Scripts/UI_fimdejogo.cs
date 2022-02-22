using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_fimdejogo : MonoBehaviour {
    public Text message;
    GameManager gm;

    private void OnEnable() {
        gm = GameManager.GetInstance();

        if (gm.vidas > 0) {
            message.text = "Você ganhou!!";
        }
        else {
            message.text = "Você perdeu! =(";
        }
    }

    public void Voltar() {
        gm.ChangeState(GameManager.GameState.GAME);
    }
}
