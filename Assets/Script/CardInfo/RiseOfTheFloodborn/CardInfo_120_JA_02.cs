using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_02 : CardInfo
{
    public CardInfo_120_JA_02()
    {
        this.cardNo = "120_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉnÅ[ÉgÇÃèóâ§";
        this.cardName2 = "é„Ç›ÇíTÇÈé“";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
