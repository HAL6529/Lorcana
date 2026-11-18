using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_08 : CardInfo
{
    public CardInfo_071_JA_08()
    {
        this.cardNo = "071_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ブルー・フェアリー";
        this.cardName2 = "導きの光";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ManeKandalyanManderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
