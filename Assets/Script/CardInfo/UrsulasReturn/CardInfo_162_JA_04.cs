using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_04 : CardInfo
{
    public CardInfo_162_JA_04()
    {
        this.cardNo = "162_JA_04";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "Dig a Little Deeper";
        this.cardName2 = "Ç‡Ç§àÍìxçlÇ¶Çƒ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether8 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
