using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_05 : CardInfo
{
    public CardInfo_142_JA_05()
    {
        this.cardNo = "142_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マーリン";
        this.cardName2 = "バミューダから帰ったとこ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
