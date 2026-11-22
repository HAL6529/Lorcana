using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_10 : CardInfo
{
    public CardInfo_050_JA_10()
    {
        this.cardNo = "050_JA_10";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クリーパー";
        this.cardName2 = "忠実なる悪の手先";
        this.power = 5;
        this.toughness = 4;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.AlejandroHernandez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
