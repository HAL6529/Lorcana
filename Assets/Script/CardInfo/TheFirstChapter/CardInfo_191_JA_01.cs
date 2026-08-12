using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_01 : CardInfo
{
    public CardInfo_191_JA_01()
    {
        this.cardNo = "191_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スターキー";
        this.cardName2 = "フックの手下";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Leonardo Giammichele";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
