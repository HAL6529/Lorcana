using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_10 : CardInfo
{
    public CardInfo_114_JA_10()
    {
        this.cardNo = "114_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ブロンクス";
        this.cardName2 = "獰猛なる獣";
        this.power = 6;
        this.toughness = 4;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.MichaelaMartinAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
