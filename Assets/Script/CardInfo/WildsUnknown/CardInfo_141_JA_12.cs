using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_12 : CardInfo
{
    public CardInfo_141_JA_12()
    {
        this.cardNo = "141_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フローラ";
        this.cardName2 = "気の長い妖精";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
