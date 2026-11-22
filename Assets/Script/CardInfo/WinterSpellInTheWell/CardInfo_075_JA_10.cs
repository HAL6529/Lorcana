using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_10 : CardInfo
{
    public CardInfo_075_JA_10()
    {
        this.cardNo = "075_JA_10";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ウラジミール";
        this.cardName2 = "ユニコーングッズ愛好家";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
