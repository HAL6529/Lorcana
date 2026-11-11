using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_05 : CardInfo
{
    public CardInfo_148_JA_05()
    {
        this.cardNo = "148_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "èóâ§";
        this.cardName2 = "âÔí∑";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LavaHijzelaarAndEllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
