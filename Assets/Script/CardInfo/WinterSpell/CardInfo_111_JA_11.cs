using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_11 : CardInfo
{
    public CardInfo_111_JA_11()
    {
        this.cardNo = "111_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "リキッデーター";
        this.cardName2 = "こおりゃ結構！";
        this.power = 4;
        this.toughness = 2;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
