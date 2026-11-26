using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_221_JA_14 : CardInfo
{
    public CardInfo_221_JA_14()
    {
        this.cardNo = "221_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トゥルーズ";
        this.cardName2 = "やんちゃざかり";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
