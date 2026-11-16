using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_06 : CardInfo
{
    public CardInfo_019_JA_06()
    {
        this.cardNo = "019_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒiƒj";
        this.cardName2 = "–…Žv‚¢‚Ì‚¨Žo‚¿‚á‚ñ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
