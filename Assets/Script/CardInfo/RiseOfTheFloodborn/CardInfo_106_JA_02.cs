using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_02 : CardInfo
{
    public CardInfo_106_JA_02()
    {
        this.cardNo = "106_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "二度とごめんだ!";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucciAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
