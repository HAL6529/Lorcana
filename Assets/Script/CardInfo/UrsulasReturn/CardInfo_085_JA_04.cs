using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_04 : CardInfo
{
    public CardInfo_085_JA_04()
    {
        this.cardNo = "085_JA_04";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ピート";
        this.cardName2 = "生まれた日からウソが得意";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
