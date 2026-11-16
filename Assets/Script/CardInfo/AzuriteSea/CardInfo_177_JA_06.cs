using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_06 : CardInfo
{
    public CardInfo_177_JA_06()
    {
        this.cardNo = "177_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マリンズ";
        this.cardName2 = "ベテラン乗組員";
        this.power = 6;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
