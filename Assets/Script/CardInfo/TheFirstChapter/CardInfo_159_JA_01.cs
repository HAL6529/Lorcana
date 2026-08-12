using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_01 : CardInfo
{
    public CardInfo_159_JA_01()
    {
        this.cardNo = "159_JA_01";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "タマトア";
        this.cardName2 = "シャイニー!";
        this.power = 5;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = "Leonardo Giammichele";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
