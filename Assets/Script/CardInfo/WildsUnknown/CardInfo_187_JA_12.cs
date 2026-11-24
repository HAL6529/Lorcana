using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_12 : CardInfo
{
    public CardInfo_187_JA_12()
    {
        this.cardNo = "187_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ファットキャット";
        this.cardName2 = "犯罪実業家";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
