using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_08 : CardInfo
{
    public CardInfo_175_JA_08()
    {
        this.cardNo = "175_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "正義守ると心に誓う";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LorenzaPigliamoscheAndLivioCacciatore;
        this.classList = new List<EnumController.Class> ();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.SingTogether6 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
