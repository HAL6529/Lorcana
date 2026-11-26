using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_14 : CardInfo
{
    public CardInfo_040_JA_14()
    {
        this.cardNo = "040_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ペピータ";
        this.cardName2 = "鋭い瞳のアレブリヘ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuertaAndLynnsMagicWorlds;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
