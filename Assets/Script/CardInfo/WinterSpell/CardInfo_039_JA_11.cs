using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_11 : CardInfo
{
    public CardInfo_039_JA_11()
    {
        this.cardNo = "039_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フリット";
        this.cardName2 = "反射的ハチドリ";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
