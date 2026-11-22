using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_10 : CardInfo
{
    public CardInfo_082_JA_10()
    {
        this.cardNo = "082_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ベルウェザー";
        this.cardName2 = "分断の扇動者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
