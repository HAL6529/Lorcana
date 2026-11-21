using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_09 : CardInfo
{
    public CardInfo_044_JA_09()
    {
        this.cardNo = "044_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アースラ";
        this.cardName2 = "歌声を奪う魔女";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
