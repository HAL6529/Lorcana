using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_12 : CardInfo
{
    public CardInfo_003_JA_12()
    {
        this.cardNo = "003_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ウッディ";
        this.cardName2 = "友を待ちながら";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
