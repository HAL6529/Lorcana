using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_06 : CardInfo
{
    public CardInfo_209_JA_06()
    {
        this.cardNo = "209_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イズマ";
        this.cardName2 = "いかがわしい化学者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.WhitneyPollett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
