using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_03 : CardInfo
{
    public CardInfo_209_JA_03()
    {
        this.cardNo = "209_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "すべての悪の支配者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
