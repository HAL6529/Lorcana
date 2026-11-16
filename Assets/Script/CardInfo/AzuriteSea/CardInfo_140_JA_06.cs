using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_06 : CardInfo
{
    public CardInfo_140_JA_06()
    {
        this.cardNo = "140_JA_06";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ガジェット・ハックレンチ";
        this.cardName2 = "カンペキな甲板長";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
