using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_10 : CardInfo
{
    public CardInfo_043_JA_10()
    {
        this.cardNo = "043_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "イアーゴ";
        this.cardName2 = "段々ダンダン！";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ReneeChio;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger5 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
