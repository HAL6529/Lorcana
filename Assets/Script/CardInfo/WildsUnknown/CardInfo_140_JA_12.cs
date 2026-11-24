using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_12 : CardInfo
{
    public CardInfo_140_JA_12()
    {
        this.cardNo = "140_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フォーナ";
        this.cardName2 = "気の長い妖精";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
