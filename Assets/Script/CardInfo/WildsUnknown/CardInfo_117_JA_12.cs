using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_12 : CardInfo
{
    public CardInfo_117_JA_12()
    {
        this.cardNo = "117_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジェデダイア・ファーンズワース";
        this.cardName2 = "クッキー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
